# CMAKE generated file: DO NOT EDIT!
# Generated by "NMake Makefiles" Generator, CMake Version 3.19

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


.SUFFIXES: .hpux_make_needs_suffix_list


# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

#Suppress display of executed commands.
$(VERBOSE).SILENT:

# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

!IF "$(OS)" == "Windows_NT"
NULL=
!ELSE
NULL=nul
!ENDIF
SHELL = cmd.exe

# The CMake executable.
CMAKE_COMMAND = "C:\Program Files\JetBrains\CLion 2021.1.2\bin\cmake\win\bin\cmake.exe"

# The command to remove a file.
RM = "C:\Program Files\JetBrains\CLion 2021.1.2\bin\cmake\win\bin\cmake.exe" -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2\cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles\Esercitazione2.dir\depend.make

# Include the progress variables for this target.
include CMakeFiles\Esercitazione2.dir\progress.make

# Include the compile flags for this target's objects.
include CMakeFiles\Esercitazione2.dir\flags.make

CMakeFiles\Esercitazione2.dir\main.c.obj: CMakeFiles\Esercitazione2.dir\flags.make
CMakeFiles\Esercitazione2.dir\main.c.obj: ..\main.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building C object CMakeFiles/Esercitazione2.dir/main.c.obj"
	C:\PROGRA~2\MIB055~1\2019\PROFES~1\VC\Tools\MSVC\1429~1.300\bin\Hostx86\x86\cl.exe @<<
 /nologo $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) /FoCMakeFiles\Esercitazione2.dir\main.c.obj /FdCMakeFiles\Esercitazione2.dir\ /FS -c C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2\main.c
<<

CMakeFiles\Esercitazione2.dir\main.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/Esercitazione2.dir/main.c.i"
	C:\PROGRA~2\MIB055~1\2019\PROFES~1\VC\Tools\MSVC\1429~1.300\bin\Hostx86\x86\cl.exe > CMakeFiles\Esercitazione2.dir\main.c.i @<<
 /nologo $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2\main.c
<<

CMakeFiles\Esercitazione2.dir\main.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/Esercitazione2.dir/main.c.s"
	C:\PROGRA~2\MIB055~1\2019\PROFES~1\VC\Tools\MSVC\1429~1.300\bin\Hostx86\x86\cl.exe @<<
 /nologo $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) /FoNUL /FAs /FaCMakeFiles\Esercitazione2.dir\main.c.s /c C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2\main.c
<<

# Object files for target Esercitazione2
Esercitazione2_OBJECTS = \
"CMakeFiles\Esercitazione2.dir\main.c.obj"

# External object files for target Esercitazione2
Esercitazione2_EXTERNAL_OBJECTS =

Esercitazione2.exe: CMakeFiles\Esercitazione2.dir\main.c.obj
Esercitazione2.exe: CMakeFiles\Esercitazione2.dir\build.make
Esercitazione2.exe: CMakeFiles\Esercitazione2.dir\objects1.rsp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking C executable Esercitazione2.exe"
	"C:\Program Files\JetBrains\CLion 2021.1.2\bin\cmake\win\bin\cmake.exe" -E vs_link_exe --intdir=CMakeFiles\Esercitazione2.dir --rc=C:\PROGRA~2\WI3CF2~1\10\bin\100190~1.0\x86\rc.exe --mt=C:\PROGRA~2\WI3CF2~1\10\bin\100190~1.0\x86\mt.exe --manifests -- C:\PROGRA~2\MIB055~1\2019\PROFES~1\VC\Tools\MSVC\1429~1.300\bin\Hostx86\x86\link.exe /nologo @CMakeFiles\Esercitazione2.dir\objects1.rsp @<<
 /out:Esercitazione2.exe /implib:Esercitazione2.lib /pdb:C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2\cmake-build-debug\Esercitazione2.pdb /version:0.0 /machine:X86 /debug /INCREMENTAL /subsystem:console  kernel32.lib user32.lib gdi32.lib winspool.lib shell32.lib ole32.lib oleaut32.lib uuid.lib comdlg32.lib advapi32.lib 
<<

# Rule to build all files generated by this target.
CMakeFiles\Esercitazione2.dir\build: Esercitazione2.exe

.PHONY : CMakeFiles\Esercitazione2.dir\build

CMakeFiles\Esercitazione2.dir\clean:
	$(CMAKE_COMMAND) -P CMakeFiles\Esercitazione2.dir\cmake_clean.cmake
.PHONY : CMakeFiles\Esercitazione2.dir\clean

CMakeFiles\Esercitazione2.dir\depend:
	$(CMAKE_COMMAND) -E cmake_depends "NMake Makefiles" C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2 C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2 C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2\cmake-build-debug C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2\cmake-build-debug C:\Users\e.cucchietti.1732\CLionProjects\Esercitazione2\cmake-build-debug\CMakeFiles\Esercitazione2.dir\DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles\Esercitazione2.dir\depend

