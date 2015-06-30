set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



--------------------------------------------------------------------------------
-- Database Name    : HISLINK_HP
-- Object Name      : dbo.PatientSex
-- DecryptSQL Ver   : Ver 3.2.0
-- Website          : http://www.devlib.net
--------------------------------------------------------------------------------
ALTER FUNCTION [dbo].[ConvertNoiTru](@noingoaitru NVARCHAR(10))
RETURNS NVARCHAR(10) 
AS 
BEGIN
	-- Declare the return variable here
	DECLARE @Noitru NVARCHAR(10)

    SET @Noitru=(CASE WHEN @noingoaitru=1 THEN 1
				WHEN @noingoaitru=0 THEN 0
				
			  end		
              ) 
   RETURN @Noitru           
END

--------------------------------------------------------------------------------



