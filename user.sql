-- 1. Tạo database mới (nếu chưa có) và sử dụng nó
CREATE DATABASE IF NOT EXISTS threeM 
CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci; -- Hỗ trợ tiếng Việt có dấu

USE threeM;

-- 2. Tạo bảng Users (Thông tin người dùng)
CREATE TABLE IF NOT EXISTS Users (
    Username VARCHAR(50) PRIMARY KEY, -- Khóa chính
    Password VARCHAR(255) NOT NULL,   -- Chiều dài 255 để an toàn nếu sau này bạn băm (hash) mật khẩu
    FullName VARCHAR(100) NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- 3. Tạo bảng UserSongs (Danh sách nhạc của người dùng)
CREATE TABLE IF NOT EXISTS UserSongs (
    Id INT AUTO_INCREMENT PRIMARY KEY, -- Khóa chính tự tăng
    Username VARCHAR(50) NOT NULL,     -- Khóa ngoại trỏ về bảng Users
    SongTitle VARCHAR(200) NOT NULL,
    Artist VARCHAR(100),
    AddedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    -- Thiết lập Khóa ngoại (Foreign Key)
    FOREIGN KEY (Username) REFERENCES Users(Username) ON DELETE CASCADE
);

-- 4. Thêm dữ liệu mẫu (Mock data) vào bảng Users
-- Mật khẩu ở đây đang để thô (plain text) là '123456' để bạn dễ test code đăng nhập
INSERT INTO Users (Username, Password, FullName) VALUES 
('admin', '123456', 'Quản Trị Viên Hệ Thống'),
('hoang', '123456', 'Huy Hoàng'),
('guest', '123456', 'Khách Vãng Lai');

-- 5. Thêm dữ liệu mẫu vào bảng UserSongs
INSERT INTO UserSongs (Username, SongTitle, Artist) VALUES 
('admin', 'Shape of You', 'Ed Sheeran'),
('admin', 'Cơn Mưa Ngang Qua', 'Sơn Tùng M-TP'),
('hoang', 'Waiting For You', 'MONO'),
('hoang', 'Nơi Này Có Anh', 'Sơn Tùng M-TP');
select * from users