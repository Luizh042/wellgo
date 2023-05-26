#!/bin/bash
proj_name="WLG"
proj_tests="${proj_name}.Tests"
cd "$proj_name"
dotnet build
cd ..