function [result,KNN_PAA_label,KNN_DTW_label,Tree_label]=ensemble(y_c,y_cPAA,y_t,sign,test_Max,test_Min)

Tmax=max(max(y_t));
Tmin=min(min(y_t));
y_t=(y_t-Tmin)/(Tmax-Tmin);
y_c=(y_c-test_Min)/(test_Max-test_Min);
y_cPAA=(y_cPAA-test_Min)/(test_Max-test_Min);

KNN_PAA_label=KNN_only(y_cPAA,y_t,sign,1)';

[train_num,train_dim]=size(y_t);
t=1;
y_t_short=zeros(21,train_dim);
sign_short=zeros(21,1);
for i=1:train_num
    if(sign(i)==t)
        y_t_short(3*(t-1)+1,:)=y_t(i,:);sign_short(3*(t-1)+1,:)=t;
        y_t_short(3*(t-1)+2,:)=y_t(i+1,:);sign_short(3*(t-1)+2,:)=t;
        y_t_short(3*t,:)=y_t(i+2,:);sign_short(3*t,:)=t;
        t=t+1;
    end
end
KNN_DTW_label=KNN(y_c,y_t_short,sign_short,1)';

Tree_label=Use_C4_5(y_t',sign',y_cPAA',5,10);

[test_num,~]=size(y_c);
result_temp=[KNN_PAA_label;KNN_DTW_label;Tree_label];
result=zeros(1,test_num);
for i=1:test_num
    result(i)=mode(result_temp(:,i));
end



