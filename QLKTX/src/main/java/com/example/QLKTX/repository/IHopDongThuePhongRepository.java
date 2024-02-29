package com.example.QLKTX.repository;

import com.example.QLKTX.entity.HopDongThuePhong;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IHopDongThuePhongRepository extends JpaRepository<HopDongThuePhong, Integer> {
    HopDongThuePhong findBySinhVienId(Integer sinhVienId);
}
