-- Abrir Query Tool sobre crud_personas, no sobre postgres.
-- No elimina tablas ni borra registros existentes.
BEGIN;

CREATE TABLE IF NOT EXISTS public.people (
    id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    age INTEGER NOT NULL,
    CONSTRAINT ck_people_name CHECK (length(btrim(name)) BETWEEN 1 AND 100),
    CONSTRAINT ck_people_age CHECK (age BETWEEN 0 AND 120)
);

-- Datos iniciales: se agregan solo cuando la tabla está vacía.
INSERT INTO public.people (name, age)
SELECT seed.name, seed.age
FROM (VALUES ('Ana', 20), ('Luis', 25), ('María', 22)) AS seed(name, age)
WHERE NOT EXISTS (SELECT 1 FROM public.people);

COMMIT;

SELECT id, name, age FROM public.people ORDER BY id;
