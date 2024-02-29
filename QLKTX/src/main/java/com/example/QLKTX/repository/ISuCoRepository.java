package com.example.QLKTX.repository;

import com.example.QLKTX.entity.SuCo;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ISuCoRepository extends JpaRepository<SuCo,Integer> {

    SuCo findByPhongId(Integer PhongId);
}
