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
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;
import javax.persistence.Table;
import java.util.Set;

@Entity
@Table(name = "phong")
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Builder
public class Phong {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "phong_id")
    private Integer phongId;

    @Column(name = "so_phong")
    private String soPhong;

    @Column(name = "tang")
    private Integer tang;

    @Column(name = "trang_thai")
    private String trangThai;

    @Column(name = "loai_phong_id")
    private String loaiPhong;

//    @ManyToOne
//    @JoinColumn(name = "loai_phong_id",referencedColumnName = "loai_phong_id")
//    private LoaiPhong loaiPhong;

//    @OneToOne(mappedBy = "phongId")
//    private HoaDonDienNuoc hoaDonDienNuoc;
//
//    @OneToMany(mappedBy = "phongId",targetEntity = HopDongThuePhong.class)
//    private Set<HopDongThuePhong> hopDongThuePhongs;

}
