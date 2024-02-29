package com.example.QLKTX.controller.resful;

import com.example.QLKTX.dto.SinhVienInforRequestDto;
import com.example.QLKTX.entity.SinhVien;
import com.example.QLKTX.service.ISinhVienService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@CrossOrigin("*")
@RequestMapping("/api/admin")
public class AdminRestController {

    @Autowired
    private ISinhVienService svService;

    @GetMapping("/getAll")
    public ResponseEntity<?> getAll(){
        List<SinhVien> sv = svService.getAll();
        if(sv!=null) {
            return new ResponseEntity<>(sv, HttpStatus.ALREADY_REPORTED);
        }
        return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
    }

}
