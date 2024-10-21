CREATE SEQUENCE users_id START 20220001;

CREATE TABLE tb_users (
    id VARCHAR(100) DEFAULT 'ST' || nextval('users_id') PRIMARY KEY,
    name VARCHAR(20),
    alamat VARCHAR(20),
    no_handphone VARCHAR(20)
);
