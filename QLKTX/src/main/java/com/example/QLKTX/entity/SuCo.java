package com.example.QLKTX.entity;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;
import java.sql.Date;

@Entity
@Table(name = "suco")
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Builder
public class SuCo {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "su_co_id")
    private Integer suCoId;

//    @ManyToOne
//    @JoinColumn(name = "phong_id", referencedColumnName = "phong_id")
//    private Phong phongId;

    @Column(name = "phong_id")
    private Integer phongId;

    @Column(name = "ngay_bao_cao")
    private Date ngayBaoCao;
    @Column(name = "mo_ta_su_co")
    private String moTaSuCo;
    @Column(name = "trang_thai_xu_ly")
    private String trangThaiXuLy;
}
