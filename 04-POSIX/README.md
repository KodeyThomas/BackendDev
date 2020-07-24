# POSIX basics

POSIX (Portable Operating System Interface) is a family set of standard Operating System interfaces in Unix Operating Systems specified by the [IEEE](https://www.ieee.org).

### What is it and why is it needed?

The entire premise of POSIX was to create a standardised set of interfaces so that when people moved their programs from one Unix based Operating System to another they could guarantee compatibility.

This allowed Companies to not have to get used to a different standards when they moved to different Unix Operating Systems

### POSIX standards over the years
POSIX before 1997 was comprised of several standards these included;

- POSIX.1 (Core Services)
- POSIX.1b (Real Time Extension Library)
- POSIX.1c (Thread Extensions)
- POSIX.2 (Shell and Utilities)

POSIX.2 laid out the foundations of CLI's and this is still the foundations of modern CLI's but just with more modern POSIX standards.

##### POSIX Post-1997

After 1997 POSIX was turned into a series of revisions by the Austin Group and these specifications are known under the name of the 'Single UNIX Specification' before they became a standard later approved by the ISO.

##### POSIX.1-2001 (Single UNIX Specification Version 3)

This standard consisted of:
  - Base Definitions (Issue 6)
  - System Interfaces and Headers (Issue 6)
  - Commands and Utilities (Issue 6)

##### POSIX.1-2008 (Base Specification Issue 7 aka POSIX 7)

This standard consisted of:
  - Base Definitions (Issue 7)
  - System Interfaces and Headers (Issue 7)
  - Commands and Utilities (Issue 7)
  - Rationale Volume

##### POSIX.1-2017

This is the current revision of the POSIX standard and is almost exactly identical to the previous 2008 revision.

### What exactly does POSIX 7 define?

POSIX 7 defines 10 base conventions these include;

1) C API
  - File Operations such as `mkdir` and `symlink`
  - Process and Threads (`fork`, `execl` and `wait`)
  - Networking with `socket()`
  - Memory Management (`mmap`, `mlock`)
  - Utilities (`reg*`)

2) CLI Utilities
  - `cd`, `ls`, `echo` - Many Utilities are direct shell front ends for C functions described above.
> Note these are not all Bash functions but most are used within Bash

3) Shell Language
  - `a=b;` `echo "$VARNAME"`
  - The most common implementation of these is in Bash

4) Environment Variables
  - `HOME` and `PATH`

5) Program Exit Statuses
  - These include an exit status of `0` for `EXIT_SUCCESS` and `1` for `EXIT_FAILURE`
  - POSIX also adds;
    - `126` for command found but not executable
    - `127` command not found
    - `> 128` terminated by a signal

6) Regular Expression
  - Most Commmon Implementation is `REGEX`

7) Directory Structure
  - `/dev/null`
  - `/tmp`
  - `/var`
  - etc

8) Filenames
  - `/` - Path Separator (/var/mobile/Documents)
  - `NUL` - Can't be used
  - `.` - Hidden File
  - `..` - Parent (`cd ..`)

9) CLI API conventions
  - `-` - A Flag (`ls -a`)
  - `--` - Terminates flags (`ls --a` lists a directory called a)

10) POSIX ACL's
  - Access Control lists

### Who Conforms to this standard?

99% of systems follow this system of conventions closely but only a few have been certified, these include `macOS` (Since 10.5)

Most Linux distros are compliant just don't want to pay the licensing fees.

Windows on the other hand, has implemented POSIX on some of it's 'Professional' distributions. However WSL (Windows Sub System for Linux) does follow POSIX guidelines.

### What I have learnt about the POSIX standard

POSIX is key to allowing developers to be able to use their skills on multiple different platforms. It also allows them port their programs to other platforms without having to learn new standards every time. This allows for greater ease of us and in the end leads to better software.
