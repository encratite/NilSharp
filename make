#!/bin/bash
shopt -s globstar
dmcs -target:library -out:Nil.dll -reference:System.Drawing -reference:System.Windows.Forms **/*.cs
