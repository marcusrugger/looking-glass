
BIN_FOLDER		= bin
TOOLKIT_FOLDER	= toolkit
FLATLAND		= lib/flatland


all:	$(BIN_FOLDER)	\
		flatland
	$(MAKE) -C $(TOOLKIT_FOLDER)


clean:
	$(MAKE) -C $(FLATLAND) clean
	$(MAKE) -C $(TOOLKIT_FOLDER) clean
	-rm -r -f $(BIN_FOLDER)


flatland:
	$(MAKE) -C $(FLATLAND)
	cp $(FLATLAND)/bin/flatland.*.dll $(BIN_FOLDER)


run:
	$(BIN_FOLDER)/lookingglass.exe


$(BIN_FOLDER):
	mkdir $(BIN_FOLDER)
