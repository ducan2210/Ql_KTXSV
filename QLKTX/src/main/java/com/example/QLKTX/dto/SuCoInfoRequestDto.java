package com.example.QLKTX.dto;

import java.sql.Date;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.sql.Date;

@Data
@AllArgsConstructor
@NoArgsConstructor

public class SuCoInfoRequestDto {

    private Integer suCoId;

    private Integer phongId;

    private Date ngayBaoCao;

    private String moTaSuCo;

    private String trangThaiXuLy;
}
