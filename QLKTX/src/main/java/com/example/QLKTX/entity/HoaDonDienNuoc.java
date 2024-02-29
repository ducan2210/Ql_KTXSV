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
import javax.persistence.OneToOne;
import javax.persistence.Table;

@Entity
@Table(name = "hoadondiennuoc")
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Builder
public class HoaDonDienNuoc {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "hoa_don_id")
    private Integer hoaDonId;

    @Column(name = "thang")
    private Integer thang;

    @Column(name = "nam")
    private Integer nam;

    @Column(name = "so_dien")
    private Integer soDien;

    @Column(name = "so_khoi_nuoc")
    private Integer soKhoiNuoc;

    @Column(name = "tong_tien")
    private Double tongTien;

    @Column(name = "trang_thai")
    private String trangThai;

    @Column(name = "phong_id")
    private Integer phongId;
//    @OneToOne
//    @JoinColumn(referencedColumnName = "phong_id",name ="phong_id")
//    private Phong phongId;
}
