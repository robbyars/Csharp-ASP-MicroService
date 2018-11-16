function check(Id)
    {
        console.log(Id);
        swal({
            title: "Are you sure?",
            text: "Are you sure that you want to delete this Order?",
            type: "warning",
            showCancelButton: true,
            closeOnConfirm: false,
            confirmButtonText: "Yes, delete it!",
            confirmButtonColor: "#ec6c62"
        },function(){
            $.ajax({
                url: "/Suppliers/Delete/",
                data:{
                    "Id": Id
                },
                type: "POST",
                success :function(response){
                    swal({
                        title: "Deleted!",
                        text: "Your file was successfully deleted!",
                        type: "success"
                    },
                     function()
                     {
                         window.location.href = '/Suppliers/Index/';
                         //settimeout(function(){
                         //     location.reload();
                         //}, 1200);

                     });
                },
                error :function(response){
                    swal("Oops", "We couldn't connect to the server!", "error");
                }
            });
        });
    }
