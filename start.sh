#!/bin/bash

if [ $MIGRATE ]
    then
        echo "Cargar migraciones"
        dotnet ef database update --project /src
        echo "Migraciones cargadas"
        if [ $? -eq 1 ]
            then
                echo "Error en ejecución. Salir."
                return 1
        fi
fi

/publish/APIContainers