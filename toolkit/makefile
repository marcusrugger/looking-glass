
SOURCE_TOOLKIT = 	toolkit.toolkit.cs				\
					toolkit.window.cs				\
					toolkit.window.application.cs

SOURCE_GTKSHARP	=	adapter.context.cs				\
					adapter.window.cs				\
					adapter.gtk-sharp.context.cs	\
					adapter.gtk-sharp.window.cs		\
					adapter.gtk-sharp.factory.cs

SOURCE_TEST_APP	=	lookingglass.cs					\
					lookingglass.window.cs


NUNIT_VERSION		=	nunit-3.2.1
NUNIT_PATH			=	/mnt/data/bin/$(NUNIT_VERSION)
NUNIT_FRAMEWORK		=	$(NUNIT_PATH)/bin/net-4.0/nunit.framework.dll
NUNIT_CONSOLE		=	$(NUNIT_PATH)/bin/nunit3-console.exe

ROOT_FOLDER		= ..
BIN_FOLDER		= $(ROOT_FOLDER)/bin

NAME_TOOLKIT	= lookingglass.toolkit.dll
NAME_GTKSHARP	= lookingglass.gtksharp.dll
NAME_TEST_APP	= lookingglass.exe

TARGET_TOOLKIT	= $(BIN_FOLDER)/$(NAME_TOOLKIT)
TARGET_GTKSHARP	= $(BIN_FOLDER)/$(NAME_GTKSHARP)
TARGET_TEST_APP	= $(BIN_FOLDER)/$(NAME_TEST_APP)

FLATLAND  			= -r:$(BIN_FOLDER)/flatland.interfaces.dll -r:$(BIN_FOLDER)/flatland.common.dll -r:$(BIN_FOLDER)/flatland.cairo.dll
PACKAGES_GTKSHARP	= -pkg:gtk-sharp-3.0


all:		$(TARGET_TEST_APP)


clean:
	-rm $(TARGET_TOOLKIT)
	-rm $(TARGET_GTKSHARP)
	-rm $(TARGET_TEST_APP)
	-rm tests.dll
	-rm tests.mdb


runtests:	tests.dll
	mono $(NUNIT_CONSOLE) tests.dll -noresult


$(TARGET_TEST_APP):	$(SOURCE_TEST_APP)		\
					$(TARGET_TOOLKIT)		\
					$(TARGET_GTKSHARP)
	mcs -out:$@ -target:exe $(ES) $(FLATLAND) -r:$(TARGET_TOOLKIT) -r:$(TARGET_GTKSHARP) $(SOURCE_TEST_APP)


$(TARGET_TOOLKIT):	$(SOURCE_TOOLKIT)		\
					$(TARGET_GTKSHARP)
	mcs 	-out:$@ -target:library $(FLATLAND) -r:$(TARGET_GTKSHARP) $(SOURCE_TOOLKIT)


$(TARGET_GTKSHARP):	$(SOURCE_GTKSHARP)
	mcs 	-out:$@ -target:library $(PACKAGES_GTKSHARP) $(FLATLAND) $^


tests.dll:			toolkit.window.test.cs	\
					$(SOURCE_TOOLKIT)
	mcs -out:$@ -targetlibrary $(PACKAGES_GTKSHARP) $(FLATLAND) -r:$(TARGET_TOOLKIT) -r:$(NUNIT_FRAMEWORK) $^
