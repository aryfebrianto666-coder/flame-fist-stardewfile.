# Flame Fist — prototipe mod Stardew Valley

Target awal: Stardew Valley 1.6.x + SMAPI. Ini adalah **proyek sumber** yang perlu dibangun lewat GitHub Actions sebelum dipasang.

## Fitur prototipe
- Senjata baru bernama Flame Fist.
- Damage dasar 100.
- Speed +10 agar ayunan lebih cepat.
- Menggunakan perilaku senjata tipe club sebagai prototipe.

## Batasan penting
Versi awal ini belum memiliki animasi kepalan tangan atau efek api visual yang terprogram. Stardew Valley memperlakukan senjata sebagai jenis senjata melee; efek pukulan tangan dan efek api khusus memerlukan pengembangan kode/asset tambahan. Jangan anggap efek api sudah aktif di build ini.

## Build melalui HP
1. Buat repo GitHub baru bernama `flame-fist-stardew`.
2. Unggah semua isi ZIP sumber ini ke repo, termasuk folder `.github/workflows`.
3. Buka tab **Actions**, pilih **Build Flame Fist**, lalu tekan **Run workflow** (atau tunggu workflow berjalan setelah commit).
4. Buka hasil run yang sukses dan unduh artifact **Flame-Fist-test-build**.
5. Ekstrak ZIP artifact. Folder `FlameFist` berisi `manifest.json` dan `FlameFist.dll`.
6. Salin folder `FlameFist` ke `StardewValley/Mods/` melalui aplikasi pengelola berkas.
7. Jalankan game lewat SMAPI. Periksa log jika ada error.

## Penting
- Buat cadangan save sebelum menguji mod.
- Build sukses tidak menjamin mod cocok dengan setiap build SMAPI Android; uji dulu.
- Senjata data-only ini mungkin perlu diperoleh lewat perintah/mod lain untuk pengujian. Cara pemberian item belum ditambahkan di prototipe.
