CREATE DATABASE "AutoKennis"
  WITH OWNER = "AutoKennis"
       ENCODING = 'UTF8'
       TABLESPACE = pg_default
       LC_COLLATE = 'Dutch_Netherlands.1252'
       LC_CTYPE = 'Dutch_Netherlands.1252'
       CONNECTION LIMIT = -1;

-- Table: public.aankoopbegeleidingform

-- DROP TABLE public.aankoopbegeleidingform;

CREATE TABLE public.aankoopbegeleidingform
(
  id integer NOT NULL DEFAULT nextval('aankoopbegeleidingform_id_seq'::regclass),
  version integer,
  attrs jsonb,
  "SENT" boolean NOT NULL DEFAULT false,
  CONSTRAINT aankoopbegeleidingform_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.aankoopbegeleidingform
  OWNER TO postgres;

  -- Table: public.aankoopkeuringform

-- DROP TABLE public.aankoopkeuringform;

CREATE TABLE public.aankoopkeuringform
(
  id integer NOT NULL DEFAULT nextval('aankoopkeuringform_id_seq'::regclass),
  version integer,
  attrs jsonb,
  "SENT" boolean NOT NULL DEFAULT false,
  CONSTRAINT aankoopkeuringform_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.aankoopkeuringform
  OWNER TO postgres;


  -- Table: public.autoadviesform

-- DROP TABLE public.autoadviesform;

CREATE TABLE public.autoadviesform
(
  id integer NOT NULL DEFAULT nextval('autoadviesform_id_seq'::regclass),
  version integer,
  attrs jsonb,
  "SENT" boolean NOT NULL DEFAULT false,
  CONSTRAINT autoadviesform_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.autoadviesform
  OWNER TO postgres;


  -- Table: public.emailreceivers

-- DROP TABLE public.emailreceivers;

CREATE TABLE public.emailreceivers
(
  email character varying(256)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.emailreceivers
  OWNER TO "AutoKennis";


  -- Table: public.garantiekeuringform

-- DROP TABLE public.garantiekeuringform;

CREATE TABLE public.garantiekeuringform
(
  id integer NOT NULL DEFAULT nextval('garantiekeuringform_id_seq'::regclass),
  version integer,
  attrs jsonb,
  sent boolean NOT NULL DEFAULT false,
  CONSTRAINT garantiekeuringform_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.garantiekeuringform
  OWNER TO "AutoKennis";


  -- Table: public.reparatiekeuringform

-- DROP TABLE public.reparatiekeuringform;

CREATE TABLE public.reparatiekeuringform
(
  id integer NOT NULL DEFAULT nextval('reparatiekeuringform_id_seq'::regclass),
  version integer,
  attrs jsonb,
  "SENT" boolean NOT NULL DEFAULT false,
  CONSTRAINT reparatiekeuringform_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.reparatiekeuringform
  OWNER TO postgres;
