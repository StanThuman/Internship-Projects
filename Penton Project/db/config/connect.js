// var MongoClient = require('mongodb').MongoClient
var mongoose = require('mongoose');

var onConnection = mongoose.connection;
var state = {
  db: null
}


exports.connect = function(url){
  if(state.db)
    return done();

  mongoose.connect(url);
}
onConnection.on('error', console.error.bind(console, 'connection error: '));
onConnection.once('open', () => {
  console.log('connectec to db successfully');

});

exports.get = function(){
  return state.db
}

exports.close = function(done){
  if(state.db){
    state.db.close(function(err, result){
      state.db = null;
      state.mode = null;
      done(err);
    });
  }
}
