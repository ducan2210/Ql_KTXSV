package com.example.QLKTX.service.impl;

import com.example.QLKTX.dto.LoginRequestDto;
import com.example.QLKTX.dto.RegisterRequestDto;
import com.example.QLKTX.dto.SinhVienInforRequestDto;
import com.example.QLKTX.entity.SinhVien;
import com.example.QLKTX.repository.ISinhVienRepository;
import com.example.QLKTX.service.ISinhVienService;
import com.example.QLKTX.security.JwtTokenUtil;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.authentication.AuthenticationServiceException;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

@Service
@RequiredArgsConstructor
public class SinhVienService implements ISinhVienService {
    @Autowired
    private final ISinhVienRepository repository;
    @Autowired
    private PasswordEncoder passwordEncoder;


    @Override
    public void save(SinhVien sinhVien) {
        repository.save(sinhVien);
    }
    @Override
    @Transactional
    public SinhVien register(RegisterRequestDto registerRequest) {
       String password = registerRequest.getSoDienThoai();
       //String cypherText = passwordEncoder.encode(password);
        SinhVien sv = new SinhVien();
        sv.setMaSinhVien(registerRequest.getMaSinhVien());
       // sv.setSoDienThoai(cypherText);
        sv.setHoTen(registerRequest.getHoTen());
        sv.setNgaySinh(registerRequest.getNgaySinh());
        sv.setCccd(registerRequest.getCccd());
        sv.setGioiTinh(registerRequest.getGioiTinh());
        sv.setSoDienThoai(password);
        sv.setDiaChi(registerRequest.getDiaChi());
        sv.setEmail(registerRequest.getEmail());
        sv.setTrangThai(registerRequest.getTrangThai());
        sv.setSoPhong(registerRequest.getSoPhong());
        //sv.setNguoiDung(registerRequest.getNguoiDung());
        repository.save(sv);
        return sv;
    }


    @Override
    public List<SinhVien> getAll() {
        return repository.findAll();
    }

    @Override
    public  SinhVien getSinhVienbyMaSinhVien(String MaSinhVien)
    {return repository.findSinhVienByMaSinhVien(MaSinhVien);}

    @Override
    @Transactional
    public void edit(SinhVienInforRequestDto sinhVien) {

        SinhVien svs =repository.findBySinhVienId(sinhVien.getSinhVienId());

        svs.setMaSinhVien(sinhVien.getMaSinhVien());
        svs.setHoTen(sinhVien.getHoTen());
        svs.setNgaySinh(sinhVien.getNgaySinh());
        svs.setCccd(sinhVien.getCccd());
        svs.setGioiTinh(sinhVien.getGioiTinh());
        svs.setSoDienThoai(sinhVien.getSoDienThoai());
        svs.setDiaChi(sinhVien.getDiaChi());
        svs.setEmail(sinhVien.getEmail());
        svs.setTrangThai(sinhVien.getTrangThai());
        svs.setSoPhong(sinhVien.getSoPhong());
        svs.setNguoiDung(sinhVien.getNguoiDung());
        repository.save(svs);

    }

    @Override
    public  boolean isSinhVienIsExists(String maSinhVien)
    {
        List<SinhVien> list= getAll();
        return list.stream().anyMatch(sinhVien -> sinhVien.getMaSinhVien().equals(maSinhVien));
    }

    @Override
    public boolean isCccdIsValid(String Cccd) {
        return Cccd != null && Cccd.length()==12;
    }

    @Override
    public boolean isEmailIsValid(String Email) {
        String emailRegex = "^[a-zA-Z0-9_+&*-]+(?:\\.[a-zA-Z0-9_+&*-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,7}$";
        // Create a Pattern object
        Pattern pattern = Pattern.compile(emailRegex);
        // Create a matcher object
        Matcher matcher = pattern.matcher(Email);
        // Return true if the email matches the pattern, otherwise false
        return matcher.matches();

    }
}
