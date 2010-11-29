#!/bin/bash
shopt -s globstar
dmcs -debug -target:library -out:Nil.dll -reference:System.Drawing -reference:System.Windows.Forms **/*.cs
