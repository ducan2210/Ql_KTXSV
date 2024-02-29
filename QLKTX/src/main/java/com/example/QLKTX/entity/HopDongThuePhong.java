package com.example.QLKTX.entity;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;
import java.sql.Date;

@Entity
@Table(name = "hopdongthuephong")
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Builder
public class HopDongThuePhong {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "hop_dong_id")
    private Integer hopDongId;

    @Column(name = "ngay_lap")
    private Date ngayLap;

    @Column(name = "ngay_bat_dau_thue")
    private Date ngayBatDauThue;

    @Column(name = "ngay_ket_thuc_thue")
    private Date ngayKetThucThue;

    @Column(name = "trangthai")
    private String trangthai;

    @Column(name = "tienthu")
    private Integer tienthu;

    @Column(name = "phong_id")
//    @ManyToOne(fetch = FetchType.LAZY)
//    @JoinColumn(name = "phong_id", referencedColumnName = "phong_id")
//    private Phong phongId;
    private Integer phongId;

    @Column(name = "sinh_vien_id")
//    @ManyToOne(fetch = FetchType.LAZY)
//    @JoinColumn(name = "sinh_vien_id",referencedColumnName = "sinh_vien_id")
//    private SinhVien sinhVienId;
      private Integer sinhVienId;
}
