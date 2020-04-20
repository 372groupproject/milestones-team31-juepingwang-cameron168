all: milestone_modules space1

ROOT_DIR:=$(shell dirname $(realpath $(firstword $(MAKEFILE_LIST))))

PROJECT1_DIR:=$(ROOT_DIR)/p4_modules

milestone_modules:
	dotnet run -p $(PROJECT1_DIR)

space1:
	@echo "\n"
