--
-- PostgreSQL database dump
--

-- Dumped from database version 9.4.9
-- Dumped by pg_dump version 9.5.1

-- Started on 2016-12-20 23:48:57

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 1 (class 3079 OID 11855)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2213 (class 0 OID 0)
-- Dependencies: 1
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

--
-- TOC entry 173 (class 1259 OID 16942)
-- Name: ano_modelo_veiculos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE ano_modelo_veiculos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE ano_modelo_veiculos_id_seq OWNER TO postgres;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 174 (class 1259 OID 16944)
-- Name: ano_modelo_veiculos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE ano_modelo_veiculos (
    id bigint DEFAULT nextval('ano_modelo_veiculos_id_seq'::regclass) NOT NULL,
    nome character varying(255) NOT NULL,
    modelo character varying(100) NOT NULL,
    valor numeric(12,2) NOT NULL,
    tipo character varying(8) NOT NULL
);


ALTER TABLE ano_modelo_veiculos OWNER TO postgres;

--
-- TOC entry 175 (class 1259 OID 16948)
-- Name: cad_bairros_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE cad_bairros_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE cad_bairros_id_seq OWNER TO postgres;

--
-- TOC entry 176 (class 1259 OID 16950)
-- Name: cad_bairros; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE cad_bairros (
    id bigint DEFAULT nextval('cad_bairros_id_seq'::regclass) NOT NULL,
    nome_bairro character varying(255),
    id_cidades bigint NOT NULL
);


ALTER TABLE cad_bairros OWNER TO postgres;

--
-- TOC entry 177 (class 1259 OID 16954)
-- Name: cad_cidades_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE cad_cidades_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE cad_cidades_id_seq OWNER TO postgres;

--
-- TOC entry 178 (class 1259 OID 16956)
-- Name: cad_cidades; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE cad_cidades (
    id bigint DEFAULT nextval('cad_cidades_id_seq'::regclass) NOT NULL,
    cidade character varying(255),
    uf character varying(255),
    cod_ibge character varying(255),
    area bigint
);


ALTER TABLE cad_cidades OWNER TO postgres;

--
-- TOC entry 179 (class 1259 OID 16963)
-- Name: cad_enderecos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE cad_enderecos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE cad_enderecos_id_seq OWNER TO postgres;

--
-- TOC entry 180 (class 1259 OID 16965)
-- Name: cad_enderecos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE cad_enderecos (
    id bigint DEFAULT nextval('cad_enderecos_id_seq'::regclass) NOT NULL,
    cep character varying(255),
    endereco character varying(255),
    bairro_id bigint,
    id_cidades bigint NOT NULL
);


ALTER TABLE cad_enderecos OWNER TO postgres;

--
-- TOC entry 181 (class 1259 OID 16972)
-- Name: cad_estados_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE cad_estados_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE cad_estados_id_seq OWNER TO postgres;

--
-- TOC entry 182 (class 1259 OID 16974)
-- Name: cad_estados; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE cad_estados (
    id bigint DEFAULT nextval('cad_estados_id_seq'::regclass) NOT NULL,
    uf character varying,
    nome_estado character varying,
    cod_ibge character varying
);


ALTER TABLE cad_estados OWNER TO postgres;

--
-- TOC entry 183 (class 1259 OID 16981)
-- Name: cliente_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE cliente_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE cliente_id_seq OWNER TO postgres;

--
-- TOC entry 184 (class 1259 OID 16983)
-- Name: cliente; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE cliente (
    id bigint DEFAULT nextval('cliente_id_seq'::regclass) NOT NULL,
    nome_completo character varying(255),
    tipo_cliente character(1),
    documento character varying(255),
    inscricao_rg character varying(255),
    "isento_ICMS" boolean,
    telefone_fixo character varying(255),
    telefone_celular character varying(255),
    email_principal character varying(255),
    email_secundario character varying(255),
    numero character varying(255),
    complemento character varying(255),
    cep character varying(255),
    referencia_comercial character varying(255),
    contato_referencia_comercial character varying(255),
    referencia_de_servico character varying(255),
    contato_referencia_de_servico character varying(255),
    referencia_de_transporte character varying(255),
    contato_referencia_de_transporte character varying(255),
    observacoes character varying(1024),
    data_cadastro date,
    data_ativacao date,
    data_inativacao date,
    inativo boolean,
    id_cidades bigint NOT NULL,
    id_enderecos bigint NOT NULL,
    id_bairros bigint NOT NULL,
    uf_estado character varying(255)
);


ALTER TABLE cliente OWNER TO postgres;

--
-- TOC entry 185 (class 1259 OID 16990)
-- Name: contas_a_receber; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE contas_a_receber (
    id bigint NOT NULL,
    id_cliente bigint,
    data_documento date,
    data_vencimento date,
    data_quitacao date,
    valor_total numeric(19,2),
    valor_desconto numeric(19,2),
    valor_quitado numeric(19,2) DEFAULT 0,
    gerado_boleto boolean DEFAULT false,
    descricao character varying(2058)
);


ALTER TABLE contas_a_receber OWNER TO postgres;

--
-- TOC entry 186 (class 1259 OID 16998)
-- Name: contas_a_receber_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE contas_a_receber_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE contas_a_receber_id_seq OWNER TO postgres;

--
-- TOC entry 2214 (class 0 OID 0)
-- Dependencies: 186
-- Name: contas_a_receber_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE contas_a_receber_id_seq OWNED BY contas_a_receber.id;


--
-- TOC entry 187 (class 1259 OID 17000)
-- Name: especies_reboque_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE especies_reboque_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE especies_reboque_id_seq OWNER TO postgres;

--
-- TOC entry 188 (class 1259 OID 17002)
-- Name: especies_reboques; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE especies_reboques (
    id bigint DEFAULT nextval('especies_reboque_id_seq'::regclass) NOT NULL,
    especie character varying(255)
);


ALTER TABLE especies_reboques OWNER TO postgres;

--
-- TOC entry 189 (class 1259 OID 17006)
-- Name: especies_veiculos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE especies_veiculos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE especies_veiculos_id_seq OWNER TO postgres;

--
-- TOC entry 190 (class 1259 OID 17008)
-- Name: especies_veiculos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE especies_veiculos (
    id bigint DEFAULT nextval('especies_veiculos_id_seq'::regclass) NOT NULL,
    especie character varying
);


ALTER TABLE especies_veiculos OWNER TO postgres;

--
-- TOC entry 191 (class 1259 OID 17015)
-- Name: historico_pagamento_sinistros_clientes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE historico_pagamento_sinistros_clientes (
    id bigint NOT NULL,
    id_sinistro bigint,
    id_cliente bigint,
    id_parcela bigint
);


ALTER TABLE historico_pagamento_sinistros_clientes OWNER TO postgres;

--
-- TOC entry 192 (class 1259 OID 17018)
-- Name: historico_pagamento_sinistros_clientes_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE historico_pagamento_sinistros_clientes_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE historico_pagamento_sinistros_clientes_id_seq OWNER TO postgres;

--
-- TOC entry 2215 (class 0 OID 0)
-- Dependencies: 192
-- Name: historico_pagamento_sinistros_clientes_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE historico_pagamento_sinistros_clientes_id_seq OWNED BY historico_pagamento_sinistros_clientes.id;


--
-- TOC entry 193 (class 1259 OID 17020)
-- Name: historico_veic_reb_sinistros_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE historico_veic_reb_sinistros_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE historico_veic_reb_sinistros_id_seq OWNER TO postgres;

--
-- TOC entry 194 (class 1259 OID 17022)
-- Name: historico_veic_reb_sinistros; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE historico_veic_reb_sinistros (
    id bigint DEFAULT nextval('historico_veic_reb_sinistros_id_seq'::regclass) NOT NULL,
    id_reboque bigint,
    id_veiculo bigint,
    identificador character(1),
    valor numeric(19,2),
    id_sinistro bigint,
    valor_a_apagar numeric(19,2),
    boleto_emitido boolean DEFAULT false,
    id_cliente bigint,
    valor_a_pagar numeric(19,2)
);


ALTER TABLE historico_veic_reb_sinistros OWNER TO postgres;

--
-- TOC entry 195 (class 1259 OID 17027)
-- Name: marca_veiculos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE marca_veiculos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE marca_veiculos_id_seq OWNER TO postgres;

--
-- TOC entry 196 (class 1259 OID 17029)
-- Name: marca_veiculos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE marca_veiculos (
    id bigint DEFAULT nextval('marca_veiculos_id_seq'::regclass) NOT NULL,
    nome character varying(255) NOT NULL,
    tipo character varying(8) NOT NULL
);


ALTER TABLE marca_veiculos OWNER TO postgres;

--
-- TOC entry 197 (class 1259 OID 17033)
-- Name: mensalidades_veiculos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE mensalidades_veiculos (
    id bigint NOT NULL,
    mes integer,
    ano integer,
    id_veiculo bigint,
    id_cliente bigint NOT NULL,
    valor numeric(19,2)
);


ALTER TABLE mensalidades_veiculos OWNER TO postgres;

--
-- TOC entry 198 (class 1259 OID 17036)
-- Name: mensalidades_veiculos_id_cliente_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE mensalidades_veiculos_id_cliente_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE mensalidades_veiculos_id_cliente_seq OWNER TO postgres;

--
-- TOC entry 2216 (class 0 OID 0)
-- Dependencies: 198
-- Name: mensalidades_veiculos_id_cliente_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE mensalidades_veiculos_id_cliente_seq OWNED BY mensalidades_veiculos.id_cliente;


--
-- TOC entry 199 (class 1259 OID 17038)
-- Name: mensalidades_veiculos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE mensalidades_veiculos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE mensalidades_veiculos_id_seq OWNER TO postgres;

--
-- TOC entry 2217 (class 0 OID 0)
-- Dependencies: 199
-- Name: mensalidades_veiculos_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE mensalidades_veiculos_id_seq OWNED BY mensalidades_veiculos.id;


--
-- TOC entry 200 (class 1259 OID 17040)
-- Name: modelo_veiculos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE modelo_veiculos (
    id character varying(100) NOT NULL,
    nome character varying(255) NOT NULL,
    marca bigint NOT NULL,
    tipo character varying(8) NOT NULL
);


ALTER TABLE modelo_veiculos OWNER TO postgres;

--
-- TOC entry 201 (class 1259 OID 17043)
-- Name: pagamentos_sinistro_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE pagamentos_sinistro_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE pagamentos_sinistro_id_seq OWNER TO postgres;

--
-- TOC entry 202 (class 1259 OID 17045)
-- Name: pagamentos_sinistro; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE pagamentos_sinistro (
    id bigint DEFAULT nextval('pagamentos_sinistro_id_seq'::regclass) NOT NULL,
    valor numeric(12,2),
    observacao character varying(255),
    id_sinistros bigint NOT NULL
);


ALTER TABLE pagamentos_sinistro OWNER TO postgres;

--
-- TOC entry 203 (class 1259 OID 17049)
-- Name: parcelas_sinistros; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE parcelas_sinistros (
    id bigint NOT NULL,
    numero_parcela integer,
    valor numeric(19,2),
    mes_parcela integer,
    ano_parcela integer,
    id_sinistro bigint
);


ALTER TABLE parcelas_sinistros OWNER TO postgres;

--
-- TOC entry 204 (class 1259 OID 17052)
-- Name: parcelas_sinistros_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE parcelas_sinistros_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE parcelas_sinistros_id_seq OWNER TO postgres;

--
-- TOC entry 2218 (class 0 OID 0)
-- Dependencies: 204
-- Name: parcelas_sinistros_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE parcelas_sinistros_id_seq OWNED BY parcelas_sinistros.id;


--
-- TOC entry 205 (class 1259 OID 17054)
-- Name: parcelas_veiculos_cc; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE parcelas_veiculos_cc (
    numero_parcela bigint,
    valor numeric(19,2),
    mes_parcela integer,
    ano_parcela integer,
    id_veiculo bigint,
    id_cliente bigint,
    gerado_conta_receber boolean DEFAULT false
);


ALTER TABLE parcelas_veiculos_cc OWNER TO postgres;

--
-- TOC entry 206 (class 1259 OID 17058)
-- Name: permicoes_usuarios_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE permicoes_usuarios_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE permicoes_usuarios_id_seq OWNER TO postgres;

--
-- TOC entry 207 (class 1259 OID 17060)
-- Name: permicoes_usuarios; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE permicoes_usuarios (
    id bigint DEFAULT nextval('permicoes_usuarios_id_seq'::regclass) NOT NULL,
    id_usuarios bigint,
    inativar_sinistro boolean,
    financeiro boolean,
    usuarios boolean,
    relatorios boolean,
    cadastrar_veiculo boolean,
    inativar_veiculo boolean,
    cadastrar_cliente boolean,
    inativar_cliente boolean,
    cadastrar_sinistro boolean,
    finalizar_sinistro boolean
);


ALTER TABLE permicoes_usuarios OWNER TO postgres;

--
-- TOC entry 208 (class 1259 OID 17064)
-- Name: preferencias_do_sistema; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE preferencias_do_sistema (
    valor_cota numeric(12,2)
);


ALTER TABLE preferencias_do_sistema OWNER TO postgres;

--
-- TOC entry 209 (class 1259 OID 17067)
-- Name: reboques_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE reboques_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE reboques_id_seq OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 17069)
-- Name: reboques; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE reboques (
    id bigint DEFAULT nextval('reboques_id_seq'::regclass) NOT NULL,
    id_veiculo bigint NOT NULL,
    id_cliente bigint,
    tara numeric(12,0),
    ano_fabricacao integer,
    chassi character varying(255),
    capacidade numeric(12,0),
    cor_chassi character varying(255),
    renavam character varying(255),
    placa character varying(255),
    ano_modelo integer,
    cor_carroceria character varying(255),
    id_estado bigint,
    uf_estado character varying(255),
    id_especies_reboques bigint,
    inativo boolean,
    valor numeric(19,2),
    data_ativacao date,
    data_cadastro date,
    data_inativacao date,
    ordem bigint,
    marca character varying(255),
    modelo character varying(255),
    id_cidade bigint
);


ALTER TABLE reboques OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 17076)
-- Name: sinistros_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE sinistros_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE sinistros_id_seq OWNER TO postgres;

--
-- TOC entry 212 (class 1259 OID 17078)
-- Name: sinistros; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE sinistros (
    id bigint DEFAULT nextval('sinistros_id_seq'::regclass) NOT NULL,
    valor_total numeric(12,2),
    situacao_sinistro bigint,
    data_ocorrido date,
    data_conclusao date,
    data_cadastro date,
    data_inativacao date,
    observacoes character varying(1024),
    numero_bo character varying,
    id_cliente bigint NOT NULL,
    id_veiculo bigint,
    id_reboque1 bigint,
    id_reboque2 bigint,
    id_reboque3 bigint,
    cotas_na_data numeric(19,3),
    clientes_no_rateio bigint
);


ALTER TABLE sinistros OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 17085)
-- Name: usuarios_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE usuarios_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE usuarios_id_seq OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 17087)
-- Name: usuarios; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE usuarios (
    id bigint DEFAULT nextval('usuarios_id_seq'::regclass) NOT NULL,
    login character varying(255),
    senha character varying(1024),
    nome_completo character varying(255),
    contato character varying(255),
    email character varying(255),
    inativo boolean
);


ALTER TABLE usuarios OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 17094)
-- Name: veiculos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE veiculos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE veiculos_id_seq OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 17096)
-- Name: veiculos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE veiculos (
    id bigint DEFAULT nextval('veiculos_id_seq'::regclass) NOT NULL,
    id_cliente bigint NOT NULL,
    cor_predominante character varying(255),
    inativo boolean,
    data_cadastro date,
    data_ativacao date,
    data_inativacao date,
    tara numeric(12,0),
    capacidade numeric(12,0),
    observacao character varying(255),
    cod_renavam character varying(255),
    numero_chassi character varying(255),
    id_especies_veiculos bigint NOT NULL,
    id_modelo_veiculos character varying(100) NOT NULL,
    id_marca_veiculos bigint NOT NULL,
    id_ano_modelo_veiculos bigint NOT NULL,
    tipo_combustivel character varying(255),
    ano_fabricacao integer,
    pot_cil character varying(255),
    valor numeric(12,2),
    placa character varying(255),
    id_cidades bigint,
    uf_estado character varying,
    gerada_parcela_cc boolean DEFAULT false
);


ALTER TABLE veiculos OWNER TO postgres;

--
-- TOC entry 2027 (class 2604 OID 17104)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY contas_a_receber ALTER COLUMN id SET DEFAULT nextval('contas_a_receber_id_seq'::regclass);


--
-- TOC entry 2030 (class 2604 OID 17105)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY historico_pagamento_sinistros_clientes ALTER COLUMN id SET DEFAULT nextval('historico_pagamento_sinistros_clientes_id_seq'::regclass);


--
-- TOC entry 2034 (class 2604 OID 17106)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY mensalidades_veiculos ALTER COLUMN id SET DEFAULT nextval('mensalidades_veiculos_id_seq'::regclass);


--
-- TOC entry 2035 (class 2604 OID 17107)
-- Name: id_cliente; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY mensalidades_veiculos ALTER COLUMN id_cliente SET DEFAULT nextval('mensalidades_veiculos_id_cliente_seq'::regclass);


--
-- TOC entry 2037 (class 2604 OID 17108)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY parcelas_sinistros ALTER COLUMN id SET DEFAULT nextval('parcelas_sinistros_id_seq'::regclass);


--
-- TOC entry 2082 (class 2606 OID 17110)
-- Name: FK_reboques_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY reboques
    ADD CONSTRAINT "FK_reboques_id" PRIMARY KEY (id);


--
-- TOC entry 2088 (class 2606 OID 17112)
-- Name: FK_veiculos_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY veiculos
    ADD CONSTRAINT "FK_veiculos_id" PRIMARY KEY (id);


--
-- TOC entry 2048 (class 2606 OID 17114)
-- Name: PK_bairros_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cad_bairros
    ADD CONSTRAINT "PK_bairros_id" PRIMARY KEY (id);


--
-- TOC entry 2050 (class 2606 OID 17116)
-- Name: PK_cidade_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cad_cidades
    ADD CONSTRAINT "PK_cidade_id" PRIMARY KEY (id);


--
-- TOC entry 2056 (class 2606 OID 17118)
-- Name: PK_clientes_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cliente
    ADD CONSTRAINT "PK_clientes_id" PRIMARY KEY (id);


--
-- TOC entry 2058 (class 2606 OID 17120)
-- Name: PK_contas_a_receber_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY contas_a_receber
    ADD CONSTRAINT "PK_contas_a_receber_id" PRIMARY KEY (id);


--
-- TOC entry 2052 (class 2606 OID 17122)
-- Name: PK_enderecos_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cad_enderecos
    ADD CONSTRAINT "PK_enderecos_id" PRIMARY KEY (id);


--
-- TOC entry 2062 (class 2606 OID 17124)
-- Name: PK_especies_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY especies_veiculos
    ADD CONSTRAINT "PK_especies_id" PRIMARY KEY (id);


--
-- TOC entry 2060 (class 2606 OID 17126)
-- Name: PK_especies_reboque_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY especies_reboques
    ADD CONSTRAINT "PK_especies_reboque_id" PRIMARY KEY (id);


--
-- TOC entry 2054 (class 2606 OID 17128)
-- Name: PK_estados_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cad_estados
    ADD CONSTRAINT "PK_estados_id" PRIMARY KEY (id);


--
-- TOC entry 2064 (class 2606 OID 17130)
-- Name: PK_historico_pagamento_sinistros_clientes_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY historico_pagamento_sinistros_clientes
    ADD CONSTRAINT "PK_historico_pagamento_sinistros_clientes_id" PRIMARY KEY (id);


--
-- TOC entry 2066 (class 2606 OID 17132)
-- Name: PK_historico_veic_reb_sinistros_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY historico_veic_reb_sinistros
    ADD CONSTRAINT "PK_historico_veic_reb_sinistros_id" PRIMARY KEY (id);


--
-- TOC entry 2070 (class 2606 OID 17134)
-- Name: PK_mensalidades_veiculos_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY mensalidades_veiculos
    ADD CONSTRAINT "PK_mensalidades_veiculos_id" PRIMARY KEY (id);


--
-- TOC entry 2074 (class 2606 OID 17136)
-- Name: PK_pagamentos_sinistro_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY pagamentos_sinistro
    ADD CONSTRAINT "PK_pagamentos_sinistro_id" PRIMARY KEY (id);


--
-- TOC entry 2076 (class 2606 OID 17138)
-- Name: PK_parcelas_sinistros_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY parcelas_sinistros
    ADD CONSTRAINT "PK_parcelas_sinistros_id" PRIMARY KEY (id);


--
-- TOC entry 2078 (class 2606 OID 17140)
-- Name: PK_restricoes_usuarios_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY permicoes_usuarios
    ADD CONSTRAINT "PK_restricoes_usuarios_id" PRIMARY KEY (id);


--
-- TOC entry 2084 (class 2606 OID 17142)
-- Name: PK_sinistros_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY sinistros
    ADD CONSTRAINT "PK_sinistros_id" PRIMARY KEY (id);


--
-- TOC entry 2086 (class 2606 OID 17144)
-- Name: PK_usuarios_do_sistema_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY usuarios
    ADD CONSTRAINT "PK_usuarios_do_sistema_id" PRIMARY KEY (id);


--
-- TOC entry 2046 (class 2606 OID 17146)
-- Name: ano_modelo_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY ano_modelo_veiculos
    ADD CONSTRAINT ano_modelo_pkey PRIMARY KEY (id);


--
-- TOC entry 2068 (class 2606 OID 17148)
-- Name: marca_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY marca_veiculos
    ADD CONSTRAINT marca_pkey PRIMARY KEY (id);


--
-- TOC entry 2072 (class 2606 OID 17150)
-- Name: modelo_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY modelo_veiculos
    ADD CONSTRAINT modelo_pkey PRIMARY KEY (id);


--
-- TOC entry 2080 (class 2606 OID 17152)
-- Name: permicoes_usuarios_uq; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY permicoes_usuarios
    ADD CONSTRAINT permicoes_usuarios_uq UNIQUE (id_usuarios);


--
-- TOC entry 2091 (class 2606 OID 17158)
-- Name: cad_bairros_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cliente
    ADD CONSTRAINT cad_bairros_fk FOREIGN KEY (id_bairros) REFERENCES cad_bairros(id) MATCH FULL ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2092 (class 2606 OID 17163)
-- Name: cad_cidades_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cliente
    ADD CONSTRAINT cad_cidades_fk FOREIGN KEY (id_cidades) REFERENCES cad_cidades(id) MATCH FULL ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2089 (class 2606 OID 17168)
-- Name: cad_cidades_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cad_bairros
    ADD CONSTRAINT cad_cidades_fk FOREIGN KEY (id_cidades) REFERENCES cad_cidades(id) MATCH FULL ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2090 (class 2606 OID 17173)
-- Name: cad_cidades_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cad_enderecos
    ADD CONSTRAINT cad_cidades_fk FOREIGN KEY (id_cidades) REFERENCES cad_cidades(id) MATCH FULL ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2093 (class 2606 OID 17183)
-- Name: cad_enderecos_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cliente
    ADD CONSTRAINT cad_enderecos_fk FOREIGN KEY (id_enderecos) REFERENCES cad_enderecos(id) MATCH FULL ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2096 (class 2606 OID 17198)
-- Name: cliente_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY sinistros
    ADD CONSTRAINT cliente_fk FOREIGN KEY (id_cliente) REFERENCES cliente(id) MATCH FULL ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2094 (class 2606 OID 17223)
-- Name: sinistros_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY pagamentos_sinistro
    ADD CONSTRAINT sinistros_fk FOREIGN KEY (id_sinistros) REFERENCES sinistros(id) MATCH FULL ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2095 (class 2606 OID 17228)
-- Name: usuarios_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY permicoes_usuarios
    ADD CONSTRAINT usuarios_fk FOREIGN KEY (id_usuarios) REFERENCES usuarios(id) MATCH FULL ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 2212 (class 0 OID 0)
-- Dependencies: 7
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2016-12-20 23:48:57

--
-- PostgreSQL database dump complete
--

