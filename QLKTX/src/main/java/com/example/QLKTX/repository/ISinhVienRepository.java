package com.example.QLKTX.repository;

import com.example.QLKTX.entity.SinhVien;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ISinhVienRepository extends JpaRepository<SinhVien, Integer> {
    SinhVien findSinhVienByMaSinhVien(String masinhvien);
    SinhVien findBySinhVienId(int id);
    SinhVien findByMaSinhVien(String MaSinhVien);


}
