package com.example.QLKTX.entity;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;
import javax.persistence.Table;
import java.sql.Date;
import java.util.HashSet;
import java.util.Set;

@Entity
@Table(name = "sinhvien")
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Builder
public class SinhVien {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "sinh_vien_id")
    private Integer sinhVienId;

    @Column(name = "ma_sinh_vien")
    private String maSinhVien;

    @Column(name = "ho_ten")
    private String hoTen;

    @Column(name = "ngay_sinh")
    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private Date ngaySinh;

    @Column(name = "cccd")
    private String cccd;

    @Column(name = "gioi_tinh")
    private String gioiTinh;

    @Column(name = "so_dien_thoai")
    private String soDienThoai;

    @Column(name = "dia_chi")
    private String diaChi;

    @Column(name = "email")
    private String email;

    @Column(name = "trang_thai")
    private String trangThai;

    @Column(name = "so_phong")
    private String soPhong;

    @Column(name = "nguoi_dung_id")
    private Integer nguoiDung;

    @OneToMany(mappedBy = "sinhVienId",targetEntity = HopDongThuePhong.class)
    private Set<HopDongThuePhong> hopDongThuePhongs = new HashSet<>();

//    @OneToOne
//    @JoinColumn(name = "nguoi_dung_id",referencedColumnName = "nguoi_dung_id")
//    private NguoiDung nguoiDung;


}
