
BIN_FOLDER		= bin
TOOLKIT_FOLDER	= toolkit
FLATLAND		= lib/flatland


all:	$(BIN_FOLDER)	\
		flatland
	$(MAKE) -C $(TOOLKIT_FOLDER)


clean:
	$(MAKE) -C $(FLATLAND) clean
	$(MAKE) -C $(TOOLKIT_FOLDER) clean


flatland:
	$(MAKE) -C $(FLATLAND)
	cp $(FLATLAND)/bin/flatland.*.dll $(BIN_FOLDER)


$(BIN_FOLDER):
	mkdir $(BIN_FOLDER)
