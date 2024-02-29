package com.example.QLKTX.repository;

import com.example.QLKTX.entity.HoaDonDienNuoc;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IHoaDonDienNuocRepository extends JpaRepository<HoaDonDienNuoc, Integer> {
    HoaDonDienNuoc findByPhongId(Integer phongId);
}
