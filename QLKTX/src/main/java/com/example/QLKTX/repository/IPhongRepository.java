package com.example.QLKTX.repository;

import com.example.QLKTX.entity.Phong;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IPhongRepository extends JpaRepository<Phong, Integer> {
    Phong findBySoPhong(String soPhong);
}
