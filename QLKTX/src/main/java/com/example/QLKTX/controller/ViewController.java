package com.example.QLKTX.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class ViewController {

    @GetMapping("/admin")
    public ModelAndView admin(){
        return new ModelAndView("admin");
    }

    @GetMapping("/login")
    public ModelAndView login(){
        return new ModelAndView("login");
    }

    @GetMapping("/home")
    public ModelAndView home(){
        return new ModelAndView("home");
    }


}
