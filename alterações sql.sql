ALTER TABLE veiculos
  ADD COLUMN gerada_parcela_cc boolean DEFAULT false;

ALTER TABLE reboques
  ADD COLUMN modelo character varying;
  ALTER TABLE reboques
  ADD COLUMN id_cidade character varying;

  ALTER TABLE parcelas_veiculos_cc
  DROP COLUMN id;
ALTER TABLE parcelas_veiculos_cc
  DROP CONSTRAINT "PK_parcelas_veiculos_cc_id";

  CREATE TABLE parcelas_sinistros
(
  id bigserial NOT NULL,
  numero_parcela integer,
  valor numeric(19,2),
  mes_parcela integer,
  ano_parcela integer,
  id_sinistro bigint,
  id_cliente bigint,
  gerado_conta_receber boolean DEFAULT false,  
  CONSTRAINT "PK_parcelas_sinistros_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE parcelas_sinistros
  OWNER TO postgres;

  CREATE TABLE parcelas_veiculos_cc
(
  id bigserial NOT NULL,
  numero_parcela bigint,
  valor numeric(19,2),
  mes_parcela integer,
  ano_parcela integer,
  id_veiculo bigint,
  id_cliente bigint,
  gerado_conta_receber boolean DEFAULT false,  
  CONSTRAINT "PK_parcelas_veiculos_cc" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE parcelas_veiculos_cc
  OWNER TO postgres;

  CREATE TABLE public.mensalidades_veiculos
(
   id bigserial NOT NULL, 
   mes integer, 
   ano integer, 
   id_veiculo bigint, 
   id_cliente bigserial, 
   valor numeric(19,2), 
   CONSTRAINT "PK_mensalidades_veiculos_id" PRIMARY KEY (id)
) 
WITH (
  OIDS = FALSE
);

ALTER TABLE historico_veic_reb_sinistros
  ADD COLUMN id_cliente bigint;
ALTER TABLE historico_veic_reb_sinistros
  ADD COLUMN valor_a_pagar numeric(19,2);

CREATE TABLE contas_a_receber
(
  id bigserial NOT NULL,
  id_cliente bigint,
  data_documento date,
  data_vencimento date,
  data_quitacao date,
  valor_total numeric(19,2),
  valor_desconto numeric(19,2),
  valor_quitado numeric(19,2) DEFAULT 0,
  gerado_boleto boolean DEFAULT false,
  descricao character varying(2058),
  CONSTRAINT "PK_contas_a_receber_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE contas_a_receber
  OWNER TO postgres;

  CREATE TABLE historico_pagamento_sinistros_clientes
(
  id bigserial NOT NULL,
  id_sinistro bigint,
  id_cliente bigint,
  CONSTRAINT "PK_historico_pagamento_sinistros_clientes_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE historico_pagamento_sinistros_clientes
  OWNER TO postgres;

  ALTER TABLE parcelas_sinistros
  DROP COLUMN gerado_conta_receber;

  ALTER TABLE historico_pagamento_sinistros_clientes
  ADD COLUMN id_parcela bigint;
ALTER TABLE parcelas_sinistros
  DROP COLUMN id_cliente;
