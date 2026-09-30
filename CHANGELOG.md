# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [1.0.2] - 2026-09-30
### Fixed
* Adds environment: release for nuget.

## [1.0.1] - 2026-09-30
### Fixed
* Version bump for ci/cd.

## [1.0.0] - 2026-09-30
### Added
* Migrates from old dotnet style projects to the new dotnet sdk style.
* Migrates all old nuget packages to the newer packages.

### Fixed
* Fixed constraints to use `where T : unmanaged` instead of a generic <T> which allows nullable.
* Disables nullables in the library projects.

### Removed
* Removed old sln projects.