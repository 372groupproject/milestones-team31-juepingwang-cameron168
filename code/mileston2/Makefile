all: milestone_if space1 milestone_loop space2

ROOT_DIR:=$(shell dirname $(realpath $(firstword $(MAKEFILE_LIST))))

PROJECT1_DIR:=$(ROOT_DIR)/p2_if
PROJECT2_DIR:=$(ROOT_DIR)/p2_loops

milestone_if:
	dotnet run -p $(PROJECT1_DIR)

space1:
	@echo "\n"

milestone_loop:
	dotnet run -p $(PROJECT2_DIR)

space2:
	@echo "\n"
