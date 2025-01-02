package com.example.demo;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class GreetingController {

    @GetMapping("/lib")
    public String lib() {
        return System.getProperty("java.library.path");
    }

    @GetMapping("/")
    public String index() {
        return "OK";
    }

    @GetMapping("/greet")
    public String greet(@RequestParam String name) {
        // Call the native function using JNA
        return GreetLibrary.INSTANCE.Greet_getGreeting(name);
    }
}