package com.example.QLKTX.controller.resful;
import com.example.QLKTX.dto.RegisterRequestDto;
import com.example.QLKTX.dto.LoginRequestDto;
import com.example.QLKTX.entity.NguoiDung;
import com.example.QLKTX.entity.SinhVien;
import com.example.QLKTX.security.JwtTokenUtil;
import com.example.QLKTX.service.INguoiDungService;
import com.example.QLKTX.service.ISinhVienService;
import com.example.QLKTX.dto.JwtResponse;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@CrossOrigin("*")
@RequestMapping("/api")
public class LoginRestController {

    @Autowired
    private ISinhVienService svService;

    @Autowired
    private INguoiDungService nguoiDungService;

    @Autowired
    private JwtTokenUtil jwtTokenUtil;

    @PostMapping(value = "/register")
    public ResponseEntity<?> register(@RequestBody RegisterRequestDto registerRequest) {
        if (svService.isSinhVienIsExists(registerRequest.getMaSinhVien()))
        {
            return ResponseEntity.ok().body("{\"status\": \"error\", \"message\": \" Mã sinh viên đã tồn tại\"}");
        }
        if (svService.isCccdIsValid(registerRequest.getCccd())==false)
        {
            return ResponseEntity.ok().body("{\"status\": \"error\", \"message\": \"Cccd không hợp lệ\"}");

        }
        if (svService.isEmailIsValid(registerRequest.getEmail())==false)
        {
            return ResponseEntity.ok().body("{\"status\": \"error\", \"message\": \"Email không hợp lệ\"}");
        }
        SinhVien sv = svService.register(registerRequest);
        return ResponseEntity.ok().body("{\"status\": \"success\", \"message\": \"Đăng kí thành công\"}");

    }


    @PostMapping(value = "/login")
    public ResponseEntity<?> createAuthenticationToken(@RequestBody LoginRequestDto authenticationRequest){
        // login dung tai khoan mat khau nguoi dung se tra ve ma token
        String token = nguoiDungService.login(authenticationRequest);
        String masinhvien = jwtTokenUtil.getMaSinhVienFromJWT(token);
        // ma token chua ma sinh vien de lay thong tin sinh vien
        SinhVien sinhVien = svService.getSinhVienbyMaSinhVien(masinhvien);
        // kiem tra thai nguoi dung va trang thai sinh vien truoc khi cho dang nhap
        String trangthai = sinhVien.getTrangThai();
        NguoiDung nguoidung= nguoiDungService.getNguoiDungbyNguoiDungID(sinhVien.getNguoiDung());
        Integer vaitro = nguoidung.getVaiTroId();
        Integer trangthainguoidung = nguoidung.getTrangThai();
        String role="";
        if (trangthai.equals("Chờ duyệt"))
        {
            return  ResponseEntity.ok("Đang chờ duyệt");
        }
        if ((trangthai.equals("Đang ở")||trangthai.equals("Đã duyệt")) &&trangthainguoidung==1 )
        {
            if (vaitro ==1)
            {
                role="ROLE_ADMIN";
            }
            if (vaitro ==2)
            {
                role="ROLE_USER";
            }
        }
        return ResponseEntity.ok(new JwtResponse(token,role));
    }

}
