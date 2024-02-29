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
import javax.persistence.OneToMany;
import javax.persistence.Table;
import java.util.HashSet;
import java.util.Set;

@Entity
@Table(name = "vaitro")
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Builder
public class VaiTro {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "vai_tro_id")
    private Integer vaiTroId;

    @Column(name = "ten_vai_tro")
    private String tenVaiTro;

    @OneToMany(mappedBy = "vaiTroId", targetEntity = NguoiDung.class)
    private Set<NguoiDung> nguoiDungs = new HashSet<>();

    @OneToMany(mappedBy = "maVaiTro", targetEntity = PhanQuyen.class)
    private Set<PhanQuyen> phanQuyens = new HashSet<>();
}
