all: milestone_modules space1 milestone_classes space2

ROOT_DIR:=$(shell dirname $(realpath $(firstword $(MAKEFILE_LIST))))

PROJECT1_DIR:=$(ROOT_DIR)/p4_modules
PROJECT2_DIR:=$(ROOT_DIR)/p4_classes

milestone_modules:
	dotnet run -p $(PROJECT1_DIR)

space1:
	@echo "\n"

milestone_classes:
	dotnet run -p $(PROJECT2_DIR)

space2:
	@echo "\n"
