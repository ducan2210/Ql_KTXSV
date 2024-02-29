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
import javax.persistence.OneToOne;
import javax.persistence.Table;
import java.util.BitSet;

@Entity
@Table(name = "nguoidung")
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Builder
public class NguoiDung {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "nguoi_dung_id")
    private Integer nguoiDungId;
    @Column(name = "ten_nguoi_dung")
    private String tenNguoiDung;
    @Column(name = "mat_khau")
    private String matKhau;
    @Column(name = "trang_thai")
    private Integer trangThai;

    @Column(name = "vai_tro_id")
    private Integer vaiTroId;

//    @ManyToOne
//    @JoinColumn(name = "vai_tro_id",referencedColumnName = "vai_tro_id")
//    private VaiTro vaiTroId;

//    @OneToOne(mappedBy = "nguoiDung",targetEntity = SinhVien.class)
//    private SinhVien sinhVien;
}
