package com.example.demo;

import com.sun.jna.*;

public interface GreetLibrary extends Library {
    GreetLibrary INSTANCE = (GreetLibrary) Native.load("greet", GreetLibrary.class);

    String Greet_getGreeting(String name);
}