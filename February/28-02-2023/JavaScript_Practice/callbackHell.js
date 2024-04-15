function getData(dataId,getNextData){
    setTimeout(()=>{
        console.log(dataId);
        if(getNextData){
            getNextData();
        }
        
    },2000)
}

getData(20,()=>{
    getData(2,()=>{
        getData(3,()=>{
            getData(4,()=>{
                getData(5);
            })
        })
    })
});
