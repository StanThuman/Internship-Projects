var getCurrentDate = () => {
  var date = new Date();
  var month = date.getMonth() + 1;
  var day = date.getDate();

  if(month < 10){
    month = '0' + month;
  }
  if(day < 10){
    day = '0' + day;
  }  
  return  month + '-' + day + '-' + date.getFullYear();
}

module.exports = getCurrentDate;
