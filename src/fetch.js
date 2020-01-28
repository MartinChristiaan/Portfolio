module.exports = {

    loadFile : function(filePath) {
        
        var result = null;
        var xmlhttp = new XMLHttpRequest();
        xmlhttp.open("GET", filePath, false);
        xmlhttp.send();
        if (xmlhttp.status == 200) {
            result = xmlhttp.responseText;
        }
        var mydata = JSON.parse(result);
        result = [mydata.loss,mydata.recnloss,mydata.prcpLoss,mydata.psnr].map(x => parseFloat(x))
        console.log(result)
        if( result[0] < result[2])
        {
            l = result[2]
            mae = result[0]
            p = result[1]
            result[0] = l
            result[1] = mae
            result[2] = p
        }
        result[2] = result[2] * 0.005
        result[1] = result[1] * 204 
        return result.map(x => x.toFixed(2))
    }
}
