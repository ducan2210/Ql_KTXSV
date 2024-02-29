package com.example.QLKTX.service;

import com.example.QLKTX.dto.SuCoInfoRequestDto;
import com.example.QLKTX.entity.SuCo;

public interface ISuCoService {
    SuCo report (SuCoInfoRequestDto suCoInfoRequest);
}
