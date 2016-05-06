
SOURCE = 	toolkit.toolkit.cs				\
			toolkit.window.cs				\
			toolkit.window.application.cs	\
			adapter.context.cs				\
			adapter.window.cs				\
			adapter.gtk-sharp.context.cs	\
			adapter.gtk-sharp.window.cs


NUNIT_VERSION		=	nunit-3.2.1
NUNIT_PATH			=	/mnt/data/bin/$(NUNIT_VERSION)
NUNIT_FRAMEWORK		=	$(NUNIT_PATH)/bin/net-4.0/nunit.framework.dll
NUNIT_CONSOLE		=	$(NUNIT_PATH)/bin/nunit3-console.exe

ROOT_DIR	= ..
BIN_DIR		= $(ROOT_DIR)/bin
DLL_NAME	= lookingglass.toolkit.dll
APP_NAME	= lookingglass.exe
TARGET		= $(BIN_DIR)/$(DLL_NAME)
TARGET_APP	= $(BIN_DIR)/$(APP_NAME)

INTERFACES  = -r:$(BIN_DIR)/flatland.interfaces.dll -r:$(BIN_DIR)/flatland.common.dll -r:$(BIN_DIR)/flatland.cairo.dll
PACKAGES	= -pkg:gtk-sharp-3.0


all:		$(TARGET_APP)


clean:
	-rm $(TARGET)
	-rm $(TARGET_APP)
	-rm tests.dll
	-rm tests.mdb


runtests:	tests.dll
	mono $(NUNIT_CONSOLE) tests.dll -noresult


$(TARGET_APP):	lookingglass.cs		\
				$(TARGET)
	mcs -out:$@ -target:exe $(PACKAGES) $(INTERFACES) -r:$(BIN_DIR)/lookingglass.toolkit.dll lookingglass.cs


$(TARGET):		$(SOURCE)
	mcs -out:$@ -target:library $(PACKAGES) $(INTERFACES) $^


tests.dll:	toolkit.window.test.cs				\
			$(SOURCE)
	mcs -out:$@ -target:library $(PACKAGES) $(INTERFACES) -r:$(NUNIT_FRAMEWORK) $^
