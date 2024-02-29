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
@Table(name = "danhmucmanhinh")
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Builder
public class DanhMucManHinh {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "Ma_Man_Hinh")
    private Integer maManHinh;
    @Column(name = "Ten_Man_Hinh")
    private String tenManHinh;

    @OneToMany(mappedBy = "maManHinh",targetEntity = PhanQuyen.class)
    private Set<PhanQuyen> phanQuyens = new HashSet<>();
}
