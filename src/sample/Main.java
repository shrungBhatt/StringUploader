package sample;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
/*import org.apache.poi.openxml4j.opc.OPCPackage;
import org.apache.poi.xssf.usermodel.XSSFCell;
import org.apache.poi.xssf.usermodel.XSSFRow;
import org.apache.poi.xssf.usermodel.XSSFSheet;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;*/

import java.io.File;
import java.io.FileWriter;

public class Main extends Application {

    @Override
    public void start(Stage primaryStage) throws Exception {
        Parent root = FXMLLoader.load(getClass().getResource("sample.fxml"));
        primaryStage.setTitle("String Uploader");
        primaryStage.setScene(new Scene(root, 600, 600));
        primaryStage.show();
    }


    public static void main(String[] args) {
/*
        try {
            OPCPackage pkg = OPCPackage.open(new File("/home/shrung/Desktop/ShowMe Vocabulary.xlsx"));
            XSSFWorkbook wb = new XSSFWorkbook(pkg);
            XSSFSheet sheet = wb.getSheetAt(0);
            XSSFRow row;
            XSSFCell cell;

            int rows; // No of rows
            rows = sheet.getPhysicalNumberOfRows();

            int cols = 0; // No of columns
            int tmp = 0;

            // This trick ensures that we get the data properly even if it doesn't start from first few rows
*/
/*            for(int i = 0; i < 10 || i < rows; i++) {
                row = sheet.getRow(i);
                if(row != null) {
                    tmp = sheet.getRow(i).getPhysicalNumberOfCells();
                    if(tmp > cols) cols = tmp;
                }
            }*//*


            for (int columnIndex = 0; columnIndex < 12; columnIndex++) {

                FileWriter fileWriter = new FileWriter("string/" + getFileName(columnIndex));

                for (int i = 2; i < rows; i++) {
                    row = sheet.getRow(i);
                    cell = row.getCell(columnIndex);
                    if (cell.getRawValue() != null) {
                        fileWriter.write(cell.getStringCellValue());
                        fileWriter.write("\n");
                    }
                }

                fileWriter.close();
            }


*/
/*            for(int r = 0; r < rows; r++) {
                row = sheet.getRow(r);
                if(row != null) {
                    for(int c = 2; c < cols; c++) {
                        cell = row.getCell((short)c);
                        if(cell != null) {
                            // Your code here
                        }
                    }
                }
            }*//*

        } catch (Exception ioe) {
            ioe.printStackTrace();
        }
*/

        launch(args);


    }

    private static String getFileName(int coloumnIndex) {
        switch (coloumnIndex) {
            case 0:
                return "key.txt";
            case 1:
                return "us.txt";
            case 2:
                return "uk.txt";
            case 3:
                return "au.txt";
            case 4:
                return "pt.txt";
            case 5:
                return "br.txt";
            case 6:
                return "fr.txt";
            case 7:
                return "ca.txt";
            case 8:
                return "es.txt";
            case 9:
                return "mx.txt";
            case 10:
                return "ar.txt";
            case 11:
                return "de.txt";
            default:
                return "strings.txt";
        }
    }
}
