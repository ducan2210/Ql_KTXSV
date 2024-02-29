package com.example.QLKTX.repository;

import com.example.QLKTX.entity.NguoiDung;
import org.springframework.data.jpa.repository.JpaRepository;

public interface INguoiDungRepository extends JpaRepository<NguoiDung, Integer> {

    NguoiDung findByTenNguoiDung(String tenguoidung);
    NguoiDung findByNguoiDungId(Integer nguoiDungID );
}
