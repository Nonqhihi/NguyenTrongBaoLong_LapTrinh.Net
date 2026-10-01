NGUYỄN TRỌNG BẢO LONG




01/10/2026
Câu 1: Sự khác nhau giữa Value
Types và Reference Types (Stack vs Heap)
•	Value Types (Kiểu giá trị):
o	Bao gồm các kiểu cơ sở (int, float, bool, char), struct, và enum.
o	Lưu trữ (Stack): Bộ nhớ được cấp phát trực tiếp trên Stack. Biến chứa trực tiếp giá trị của dữ liệu.
o	Vòng đời: Tự động giải phóng ngay khi ra khỏi phạm vi (scope) khai báo, tốc độ truy xuất và cấp phát rất nhanh.
•	Reference Types (Kiểu tham chiếu):
o	Bao gồm class, object, string, array, delegate.
o	Lưu trữ (Heap & Stack): Dữ liệu thực tế được lưu trên vùng nhớ Heap. Biến khai báo (nằm trên Stack) chỉ chứa địa chỉ (tham chiếu/pointer) trỏ tới vùng nhớ Heap đó.
o	Vòng đời: Bộ nhớ trên Heap được quản lý và dọn dẹp tự động bởi bộ thu gom rác (Garbage Collector - GC) khi không còn biến nào tham chiếu tới nó.
Câu 2: Khác biệt giữa init và set thông thường
•	Thuộc tính dùng set: Cho phép gán và thay đổi giá trị của thuộc tính ở bất kỳ đâu và bất kỳ lúc nào trong suốt vòng đời của đối tượng.
•	Thuộc tính dùng init: Chỉ cho phép gán giá trị một lần duy nhất trong quá trình khởi tạo đối tượng (thông qua Constructor hoặc Object Initializer { }). Ngay sau khi đối tượng được khởi tạo xong, thuộc tính đó sẽ trở thành chỉ đọc (Read-only/Immutable).
•	Trường hợp sử dụng thực tế: Dùng để tạo ra các đối tượng bất biến (Immutable Objects), ví dụ như các Data Transfer Objects (DTO) để truyền tải dữ liệu giữa các API, hoặc các model cấu hình. Nó cho phép cú pháp khởi tạo đối tượng ngắn gọn nhưng vẫn đảm bảo dữ liệu không bị thay đổi ngoài ý muốn sau đó.
Câu 3: Phân biệt virtual ở lớp cha và override ở lớp con
•	Từ khóa virtual (Lớp cha): Được sử dụng để khai báo một phương thức có sẵn phần thân (logic mặc định) và cho phép (nhưng không bắt buộc) các lớp con ghi đè lại (thay đổi) logic đó.
•	Từ khóa override (Lớp con): Được sử dụng để ghi đè (cung cấp một logic mới) cho phương thức đã được đánh dấu là virtual (hoặc abstract) từ lớp cha.
•	Mối liên hệ trong Đa hình: Khi gọi một phương thức thông qua biến kiểu lớp cha nhưng đang trỏ tới đối tượng lớp con, trình biên dịch sẽ tìm kiếm xem lớp con có dùng override hay không để quyết định gọi phương thức của lớp con (Dynamic Polymorphism - Ràng buộc ở thời gian chạy).
Câu 4: Tại sao thành phần static không thể truy xuất qua một thể hiện (Object Instance)?
•	Từ khóa static chỉ định rằng một thuộc tính hoặc phương thức thuộc về chính bản thân Lớp (Class) đó, chứ không thuộc về bất kỳ một đối tượng (Instance) cụ thể nào.
•	Về mặt bộ nhớ, thành phần static chỉ được cấp phát một vùng nhớ duy nhất và dùng chung cho tất cả các đối tượng sinh ra từ lớp đó.
•	Vì toán tử new tạo ra một vùng nhớ riêng biệt cho một đối tượng cụ thể (Instance), thành phần static không nằm trong cấu trúc bộ nhớ của đối tượng đó. Do vậy, C# bắt buộc bạn phải gọi thành phần static thông qua tên Lớp (TenLop.ThanhPhanStatic) thay vì qua biến đối tượng.
