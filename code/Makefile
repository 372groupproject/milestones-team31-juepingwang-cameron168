all: say_hello space1 something_else space2

ROOT_DIR:=$(shell dirname $(realpath $(firstword $(MAKEFILE_LIST))))

PROJECT1_DIR:=$(ROOT_DIR)/helloWorld
PROJECT2_DIR:=$(ROOT_DIR)/somethingElse

say_hello:
	@echo "Hello World program:"
	dotnet run -p $(PROJECT1_DIR)

space1:
	@echo "\n"

something_else:
	@echo "Something else program:"
	dotnet run -p $(PROJECT2_DIR)

space2:
	@echo "\n"
