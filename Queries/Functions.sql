-- Function to Insert a new user
CREATE OR REPLACE FUNCTION st_insert
(
	_name VARCHAR,
	_alamat VARCHAR,
	_no_handphone VARCHAR
)
RETURNS INT AS $$
BEGIN
	INSERT INTO public.tb_users
	(
		name,
		alamat,
		no_handphone
	)
	VALUES
	(
		_name,
		_alamat,
		_no_handphone
	);

	IF FOUND THEN
		RETURN 1;
	ELSE
		RETURN 0;
	END IF;
END;
$$ LANGUAGE plpgsql;

-- Function to Select all users
CREATE OR REPLACE FUNCTION st_select()
RETURNS TABLE(id VARCHAR, name VARCHAR, alamat VARCHAR, no_handphone VARCHAR) AS $$
BEGIN
	RETURN QUERY
	SELECT id, name, alamat, no_handphone FROM tb_users;
END;
$$ LANGUAGE plpgsql;

-- Function to Update a user
CREATE OR REPLACE FUNCTION st_update
(
	_id VARCHAR,
	_name VARCHAR,
	_alamat VARCHAR,
	_no_handphone VARCHAR
)
RETURNS INT AS $$
BEGIN
	UPDATE tb_users SET
		name = _name,
		alamat = _alamat,
		no_handphone = _no_handphone
	WHERE id = _id;
	IF FOUND THEN
		RETURN 1;
	ELSE
		RETURN 0;
	END IF;
END;
$$ LANGUAGE plpgsql;

-- Function to Delete a user
CREATE OR REPLACE FUNCTION st_delete(_id VARCHAR)
RETURNS INT AS $$
BEGIN
	DELETE FROM public.tb_users
	WHERE id = _id;
	IF FOUND THEN
		RETURN 1;
	ELSE
		RETURN 0;
	END IF;
END;
$$ LANGUAGE plpgsql;
