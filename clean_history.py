import re

# Matcht nur Blöcke mit der Dateiendung .json im Resources-Ordner
pattern = rb'<None\s+Update="Resources\\[^"]+\.json">.*?</None>'

# Ersetzt den gesamten gefundenen Block durch nichts (restloses Löschen)
blob.data = re.sub(pattern, b"", blob.data, flags=re.DOTALL)
