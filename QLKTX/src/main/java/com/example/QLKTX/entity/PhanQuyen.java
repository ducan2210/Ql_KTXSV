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

@Entity
@Table(name = "phanquyen")
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Builder
public class PhanQuyen {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "ma_phan_quyen")
    private Integer maPhanQuyen;

    @ManyToOne
    @JoinColumn(name = "Ma_Vai_Tro",referencedColumnName = "vai_tro_id")
    private VaiTro maVaiTro;

    @ManyToOne
    @JoinColumn(name = "Ma_Man_Hinh",referencedColumnName = "Ma_Man_Hinh")
    private DanhMucManHinh maManHinh;

    @Column(name = "Co_Quyen")
    private Boolean coQuyen;


}
