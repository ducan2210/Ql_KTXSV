package com.example.QLKTX.service;

import com.example.QLKTX.repository.ISinhVienRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class JwtUserDetailsService implements UserDetailsService {

	@Autowired
	private ISinhVienRepository svRepository;

	@Override
	public UserDetails loadUserByUsername(String MaSinhVien) throws UsernameNotFoundException {
		com.example.QLKTX.entity.SinhVien sv = svRepository.findByMaSinhVien(MaSinhVien);

		if (sv == null) {
			throw new UsernameNotFoundException("This" + MaSinhVien + "was not found in database!");
		}

		List<GrantedAuthority> grantedAuthorities = new ArrayList<>();
		grantedAuthorities.add(new SimpleGrantedAuthority("ROLE_USER"));

		UserDetails userDetails = new org.springframework.security.core.userdetails.User(
				sv.getMaSinhVien(),
				sv.getSoDienThoai(),
				grantedAuthorities);

		return userDetails;
	}

}