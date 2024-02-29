package com.example.QLKTX.controller.resful;
import com.example.QLKTX.dto.*;
import com.example.QLKTX.entity.*;
import com.example.QLKTX.service.*;
import org.springframework.beans.BeanUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import com.example.QLKTX.security.JwtRequestFilter;
import com.example.QLKTX.security.JwtTokenUtil;
import javax.servlet.http.HttpServletRequest;

@RestController
@CrossOrigin("*")
@RequestMapping("/api")
public class HomeRestController {

    @Autowired
    private ISinhVienService svService;
    @Autowired
    private IHopDongThuePhongService hdService;
    @Autowired
    private ISuCoService suCoService;
    @Autowired
    private IPhongService phongService;
    @Autowired
    IHoaDonDienNuocService hoaDonDienNuocService;
    @Autowired
    private JwtRequestFilter jwtRequestFilter;
    @Autowired
    private JwtTokenUtil jwtTokenUtil;

    @GetMapping("/profile")
    public ResponseEntity<?> createAuthenticationToken(HttpServletRequest request){
        String token = jwtRequestFilter.getJwtFromRequest(request);
        String MaSinhVien = jwtTokenUtil.getMaSinhVienFromJWT(token);
        SinhVien sv = new SinhVien();
        sv = svService.getSinhVienbyMaSinhVien(MaSinhVien);
        return ResponseEntity.ok(sv);
    }

    @PutMapping ("/edit")
    public ResponseEntity<?> editInfo(@RequestBody SinhVienInforRequestDto sinhVien,HttpServletRequest request){
//        String token = jwtRequestFilter.getJwtFromRequest(request);
//        String MaSinhVien = jwtTokenUtil.getMaSinhVienFromJWT(token);
//        String masv = sinhVien.getMaSinhVien();
            if (svService.isCccdIsValid(sinhVien.getCccd())==false)
            {
                return ResponseEntity.ok().body("{\"status\": \"error\", \"message\": \"Cccd không hợp lệ\"}");
            }
            if (svService.isEmailIsValid(sinhVien.getEmail())==false)
            {
                return ResponseEntity.ok().body("{\"status\": \"error\", \"message\": \"Email không hợp lệ\"}");
            }
            svService.edit(sinhVien);
            return ResponseEntity.ok().body("{\"status\": \"success\", \"message\": \"Chỉnh sửa thông tin thành công\"}");
//        else
//        {
//            if (svService.isSinhVienIsExists(masv)) {
//                return ResponseEntity.ok().body("{\"status\": \"error\", \"message\": \" Mã sinh viên đã tồn tại\"}");
//            }
//
//            if (svService.isCccdIsValid(sinhVien.getCccd())==false)
//            {
//                return ResponseEntity.ok().body("{\"status\": \"error\", \"message\": \" Cccd không hợp lệ\"}");
//            }
//            if (svService.isEmailIsValid(sinhVien.getEmail())==false)
//            {
//                return ResponseEntity.ok().body("{\"status\": \"error\", \"message\": \" Email không hợp lệ\"}");
//            }
//            svService.edit(sinhVien);
//            return ResponseEntity.ok().body("{\"status\": \"success\", \"message\": \"Chỉnh sửa thông tin thành công\"}");
//        }
    }

    @GetMapping("/logout")
    public ResponseEntity<?> logout(){
        return ResponseEntity.ok(HttpStatus.OK);
    }

    @GetMapping("/contract")
    public ResponseEntity<?> gethopdong(HttpServletRequest request){
        String token = jwtRequestFilter.getJwtFromRequest(request);
        String MaSinhVien = jwtTokenUtil.getMaSinhVienFromJWT(token);
        SinhVien sinhVien = svService.getSinhVienbyMaSinhVien(MaSinhVien);
        Integer sinhVienId = sinhVien.getSinhVienId();
        HopDongThuePhong hd = new HopDongThuePhong();
        hd=hdService.getHopDongThuePhongbySinhVienID(sinhVienId);
        return ResponseEntity.ok(hd);
    }
    @PostMapping(value = "/report")
    public ResponseEntity<?> report(@RequestBody SuCoInfoRequestDto  suCoInfoRequest){
        SuCo suCo = suCoService.report(suCoInfoRequest);
        return ResponseEntity.ok(suCo);
    }

    @GetMapping("/room")
    public ResponseEntity<?> getRoom(HttpServletRequest request){
        String token = jwtRequestFilter.getJwtFromRequest(request);
        String MaSinhVien = jwtTokenUtil.getMaSinhVienFromJWT(token);
        SinhVien sinhVien = svService.getSinhVienbyMaSinhVien(MaSinhVien);
        String soPhong = sinhVien.getSoPhong();
        Phong p = new Phong();
        p = phongService.getPhongbySoPhongSinhVien(soPhong);
        return ResponseEntity.ok(p);
    }
    @GetMapping("/bill")
    public ResponseEntity<?> getElectricityAndWaterBill(HttpServletRequest request){
        String token = jwtRequestFilter.getJwtFromRequest(request);
        String MaSinhVien = jwtTokenUtil.getMaSinhVienFromJWT(token);
        SinhVien sinhVien = svService.getSinhVienbyMaSinhVien(MaSinhVien);
        String soPhong = sinhVien.getSoPhong();
        Phong p = new Phong();
        p = phongService.getPhongbySoPhongSinhVien(soPhong);
        HoaDonDienNuoc hoaDonDienNuoc = new HoaDonDienNuoc();
        hoaDonDienNuoc = hoaDonDienNuocService.gethdbyPhongid(p.getPhongId());
        return ResponseEntity.ok(hoaDonDienNuoc);
    }
}
