Add-migration Authen -Context ApplicationDBContext
update-database Authen -Context ApplicationDBContext

Add-migration Clinic -Context Clinic_MVCContext
 update-database Clinic -Context Clinic_MVCContext