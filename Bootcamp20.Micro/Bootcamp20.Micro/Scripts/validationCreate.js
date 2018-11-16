function validateData()
{  
    debugger;  
        
    if ($("#NameSupplier").val() == "")  
    {  
        swal("Please enter Supplier Name !");  
        return false;  
          
    } else   
    {  
        return true;  
    }  
}