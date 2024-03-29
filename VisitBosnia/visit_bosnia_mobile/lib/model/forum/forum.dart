import '../city/city.dart';

class Forum {
  int? id;
  String? title;
  int? cityId;
  String? createdTime;
  City? city;

  Forum({this.id, this.title, this.cityId, this.createdTime, this.city});

  Forum.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    title = json['title'];
    cityId = json['cityId'];
    createdTime = json['createdTime'];
    city = json['city'] != null ? new City.fromJson(json['city']) : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['id'] = this.id;
    data['title'] = this.title;
    data['cityId'] = this.cityId;
    data['createdTime'] = this.createdTime;
    if (this.city != null) {
      data['city'] = this.city!.toJson();
    }
    return data;
  }
}
