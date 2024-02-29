package com.example.QLKTX.service.impl;

import com.example.QLKTX.dto.SuCoInfoRequestDto;
import com.example.QLKTX.entity.SuCo;
import com.example.QLKTX.repository.ISuCoRepository;
import com.example.QLKTX.service.ISuCoService;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

@Service
@RequiredArgsConstructor

public class SuCoService implements ISuCoService {
    @Autowired
    private ISuCoRepository SuCoRepository;
    @Override
    @Transactional
    public SuCo report(SuCoInfoRequestDto suCoInfoRequest) {
        SuCo sc = new SuCo();
        sc.setPhongId(suCoInfoRequest.getPhongId());
        sc.setNgayBaoCao(suCoInfoRequest.getNgayBaoCao());
        sc.setMoTaSuCo(suCoInfoRequest.getMoTaSuCo());
        sc.setTrangThaiXuLy(suCoInfoRequest.getTrangThaiXuLy());
        SuCoRepository.save(sc);
        return sc;
    }
}
