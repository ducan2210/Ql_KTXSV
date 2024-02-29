package com.example.QLKTX.controller;

import com.example.QLKTX.entity.SinhVien;
import com.example.QLKTX.service.ISinhVienService;
import lombok.RequiredArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("api/sinh-vien/")
@RequiredArgsConstructor
public class SinhVienController {
    private final ISinhVienService sinhVienService;

    @PostMapping("create")
    public ResponseEntity<String> createSinhVien(@RequestBody SinhVien sinhVien) {
        sinhVienService.save(sinhVien);
        return new ResponseEntity<>("Them moi thanh cong",HttpStatus.OK);
    }
}
